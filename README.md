## Dapr Demo PubSub Controller Based

1. [Install Dapr CLI](https://docs.dapr.io/getting-started/install-dapr-cli/#step-1-install-the-dapr-cli)
2. [Initialize Dapr in your local environment](https://docs.dapr.io/getting-started/install-dapr-selfhost/)
3. Run Controller Consumer

   `dapr run --app-id controller --app-port 6000 -- dotnet run `

4. Run Controller Publisher 

    `dapr run --app-id controller --app-port 6000 -- dotnet run`
5. Go to swagger page and try pushing request on publisher app
