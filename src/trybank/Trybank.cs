namespace Trybank.Lib;

public class TrybankLib
{
    public bool Logged;
    public int loggedUser;

    //0 -> Número da conta
    //1 -> Agência
    //2 -> Senha
    //3 -> Saldo
    public int[,] Bank;
    public int registeredAccounts;
    private int maxAccounts = 50;

    public TrybankLib()
    {
        loggedUser = -99;
        registeredAccounts = 0;
        Logged = false;
        Bank = new int[maxAccounts, 4];
    }

    // 1. Construa a funcionalidade de cadastrar novas contas
    public void RegisterAccount(int number, int agency, int pass)
    {
        int[]? account = this.GetAccount(number, agency);
        if (account != null) throw new ArgumentException("A conta já está sendo usada!");
        this.Bank[registeredAccounts, 0] = number;
        this.Bank[registeredAccounts, 1] = agency;
        this.Bank[registeredAccounts, 2] = pass;
        this.Bank[registeredAccounts, 3] = 0;
        registeredAccounts += 1;
    }

    // 2. Construa a funcionalidade de fazer Login
    public void Login(int number, int agency, int pass)
    {
        if (this.Logged) throw new AccessViolationException("Usuário já está logado");
        int[]? userAccount = this.GetAccount(number, agency);
        if (userAccount == null) throw new ArgumentException("Agência + Conta não encontrada");
        if (pass != userAccount[2]) throw new ArgumentException("Senha incorreta");
        this.Logged = true;
        this.loggedUser = userAccount[4];
    }

    private int[]? GetAccount(int number, int agency)
    {
        for (int index = 0; index < this.Bank.Length && index != registeredAccounts; index++)
        {
            int accountNumber = this.Bank[index, 0];
            int accountAgency = this.Bank[index, 1];
            if (accountNumber == number && accountAgency == agency)
            {
                int[] userAccount = new int[5];
                userAccount[0] = accountNumber;
                userAccount[1] = accountAgency;
                userAccount[2] = this.Bank[index, 2];
                userAccount[3] = this.Bank[index, 3];
                userAccount[4] = index;
                return userAccount;
            }
        }
        return null;
    }

    private bool AuthenticateUser()
    {
        if (!this.Logged) throw new AccessViolationException("Usuário não está logado");
        return true;
    }

    // 3. Construa a funcionalidade de fazer Logout
    public void Logout()
    {
        this.AuthenticateUser();
        this.Logged = false;
        this.loggedUser = -99;
    }

    // 4. Construa a funcionalidade de checar o saldo
    public int CheckBalance()
    {
        this.AuthenticateUser();
        int userId = this.loggedUser;
        return this.Bank[userId, 3];
    }

    // 5. Construa a funcionalidade de depositar dinheiro
    public void Deposit(int value)
    {
        throw new NotImplementedException();
    }

    // 6. Construa a funcionalidade de sacar dinheiro
    public void Withdraw(int value)
    {
        throw new NotImplementedException();
    }

    // 7. Construa a funcionalidade de transferir dinheiro entre contas
    public void Transfer(int destinationNumber, int destinationAgency, int value)
    {
        throw new NotImplementedException();
    }

   
}
