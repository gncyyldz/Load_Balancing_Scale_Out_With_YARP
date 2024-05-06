dotnet run '1. server' --launch-profile https1
dotnet run '2. server' --launch-profile https2
dotnet run '3. server' --launch-profile https3

k6 run --out json=result.json .\k6-test.js
