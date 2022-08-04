Install:

    npm install -g pouchdb-server

run:

    pouchdb-server --port 5984

then run

    npm install -g add-cors-to-couchdb
    add-cors-to-couchdb

then re-run (default port is 5984):

     pouchdb-server --port 3000


Now you can view the [Fauxton](https://github.com/apache/couchdb-fauxton) web interface by opening http://localhost:3000/_utils in a browser.
Basic options

    npm install -g add-cors-to-couchdb
    add-cors-to-couchdb
