# GraphQL for .NET

![alt](https://gridsome.org/assets/static/import-data.eb9be63.3e0083b3c8c40a300ab593b006f88025.png)

https://github.com/graphql-dotnet/graphql-dotnet

`dotnet add package GraphQL.SystemTextJson`

`dotnet add package GraphQL.NewtonsoftJson`

`dotnet add package GraphQL.Server.All`

`dotnet restore`

http://localhost:60341/ui/playground

http://localhost:60341/ui/graphiql

### Sample-specific 

#### Query
    {
      messages {
        content
        sentAt
        from {
          displayName
        }
      }
    }

#### Add new

    mutation {
      addMessage(message: { fromId: "1", content: "hello" }) {
        content
        from {
          displayName
        }
        sentAt
      }
    }

#### Pub/sub 

    subscription {
      messageAdded {
        content
        sentAt
        from {
          displayName
        }
      }
    }



http://localhost:60341/ui/altair

http://localhost:60341/ui/voyager


