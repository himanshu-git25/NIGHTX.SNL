const { ipcRenderer } = require('electron');

document.getElementById("runBtn").addEventListener("click", () => {
  const code = document.getElementById("editor").value;
  ipcRenderer.send('run-code', code);
});

ipcRenderer.on('code-output', (event, result) => {
  document.getElementById("outputText").textContent = result;
});
