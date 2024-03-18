curl https://stablehorde.net/api/swagger.json > swagger.json
(Get-Content swagger.json).Replace('*', 'param') | Set-Content swagger.json
yq -p json -o yaml swagger.json > swagger.yaml
openapi-generator-cli generate -g csharp -c config.json -i swagger.yaml