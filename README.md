dotnet run '1. server' --launch-profile https1 <br>
dotnet run '2. server' --launch-profile https2 <br>
dotnet run '3. server' --launch-profile https3 <br>

murat biltekin
k6 run --out json=result.json .\k6-test.js
