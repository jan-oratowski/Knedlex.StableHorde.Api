curl https://stablehorde.net/api/swagger.json > swagger.json
yq -p json -o yaml swagger.json > swagger.yaml
openapi-generator-cli generate -g csharp-netcore -c config.json -i swagger.yaml