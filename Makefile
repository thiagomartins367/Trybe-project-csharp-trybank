start: # Ex: make start
	dotnet run --project ./src/trybank/trybank.csproj

format-trybank: # Ex: make format-trybank
	dotnet format ./src/src.sln --verify-no-changes --report ./format.json --include ./trybank/Trybank.cs diagnostic

test: # Ex: make test
	dotnet test ./src/src.sln

test-req: # Ex: make req-number=1 test-req
	dotnet test --filter 'TestReq$(req-number)' ./src/src.sln