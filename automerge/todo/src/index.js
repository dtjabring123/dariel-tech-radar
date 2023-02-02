import * as Automerge from "@automerge/automerge"
let docId = window.location.hash.replace(/^#/, '')
let binary = await localforage.getItem(docId)
let doc = Automerge.init()

if (binary) {
  doc = Automerge.load(binary)
  render(doc)
}

// console.log(doc)
function updateDoc(newDoc) {
  doc = newDoc
  render(newDoc)
  let binary = Automerge.save(newDoc)
  localforage.setItem(docId, binary).catch(err => console.log(err))
}

function addItem(text) {
  let newDoc = Automerge.change(doc, doc => {
    if (!doc.items) doc.items = []
    doc.items.push({ text, done: false })
  })
  updateDoc(newDoc)
}

document.querySelector("form").onsubmit = (ev) => {
  const input = document.querySelector("#new-todo")

  ev.preventDefault()
  addItem(input.value)
  input.value = null
}

function render(doc) {
  let list = document.querySelector("#todo-list")
  list.innerHTML = ''
  doc.items && doc.items.forEach((item, index) => {
    let itemEl = document.createElement('li')
    itemEl.innerText = item.text
    itemEl.style = item.done ? 'text-decoration: line-through' : ''
    list.appendChild(itemEl)
  })
}