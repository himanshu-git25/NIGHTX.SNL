body {
  margin: 0;
  font-family: 'Consolas', monospace;
  background: #1e1e1e;
  color: #ffffff;
  display: flex;
  flex-direction: column;
  height: 100vh;
}

#container {
  display: flex;
  height: 100%;
}

#sidebar {
  width: 200px;
  background: #2d2d2d;
  padding: 10px;
  box-shadow: 2px 0 5px #000;
}

#editorContainer {
  flex-grow: 1;
  padding: 10px;
}

#editor {
  width: 100%;
  height: 80vh;
  background: #1e1e1e;
  color: #ffffff;
  border: none;
  font-size: 16px;
  resize: none;
}

#actions {
  padding: 10px;
  background: #2d2d2d;
  text-align: right;
}

#runBtn {
  padding: 8px 16px;
  font-size: 16px;
  background: #00cc88;
  border: none;
  cursor: pointer;
  border-radius: 5px;
}

#output {
  padding: 10px;
  height: 150px;
  overflow: auto;
  background: #111;
  border-top: 2px solid #444;
}

#outputText {
  white-space: pre-wrap;
}
