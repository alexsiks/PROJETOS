async function imprimir() {
    await eel.call_in_js("oii")
}

imprimir()

eel.expose(call_in_python)

function call_in_python(x) {
    console.log(x)
    document.getElementById('mensagem-python').innerHTML = (x)

}