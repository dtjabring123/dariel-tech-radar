`npm install automerge`

or 

`yarn add automerge`

then 

`yarn webpack serve` 

and 

goto http://localhost:8080

We can access the hash in the browser client as a unique identifier. For example, if you want to make a new todo list called 'groceries', the URL would be:

http://localhost:8080/#groceries 

## 1st doc

https://automerge.org/docs/tutorial/create-a-document/

An Automerge document is a JSON object. 

Similar to a NoSQL collection, a document allows you to track the state of your application.

To create a new document, we want to start with

>let doc = Automerge.init()

This document is a simple JavaScript object, which can be accessed like any other object.

However, you can't just set properties on an Automerge document. With a typical JavaScript object, you might do:

> let obj = {}

> obj.count = 0

> obj.count++

> obj

    { count: 1 }

In contrast, Automerge documents are immutable and follow a functional pattern. This means that you can retrieve properties from a document, but you can't change them like you would in a typical JavaScript object. Instead, you need to use Automerge.change(), which we discuss in the next section.

Let's store the current document in a global variable doc, which is initialized as shown above. We also define a function that we call whenever the document changes:

    function updateDoc(newDoc) {
      doc = newDoc
    } 

function only updates global variable doc (later we will add more code to this function)
## ActorId​

Each instance of a document has an actorId. This is useful for Automerge to know which process or device is making changes. It's important that every process has a unique actorId. Every time you make an Automerge document, it automatically generates an actorId for you.

To try this out, print it to the console using Automerge.getActorId(doc):

    let doc = Automerge.init()
    let actorId = Automerge.getActorId(doc)
    console.log(actorId)

Every time you refresh the page, the actorId is a different randomly generated string.


