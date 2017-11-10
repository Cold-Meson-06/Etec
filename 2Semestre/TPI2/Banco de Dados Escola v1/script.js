void function main() {

    //Não é o JQuery (i = id)
    const N$ = (i) =>  document.getElementById(i)

    //Será usado para gerar strings aleatorias
    const letters = 'abcdefghijklmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ'.split('');

    //Gera uma string aleatoria (t = tamanho)
    const randStr = t => new Array(t).fill(0).map(e => letters[parseInt(Math.random() * letters.length)]).join('')

    //Gera um número aleatorio (m = maximo)
    const randNum = m => parseInt(Math.random() * m) + 1 //+ 1 Para não gerar o numero 0;

    //Componentes do tipo varchar
    const charComp = ['inputNome', 'inputRua', 'inputBairro', 'inputCidade'].map(e => N$(e))

    //Componentes do tipo int
    const numComp = ['inputRA', 'inputNumero'].map(e => N$(e))

    //estado é varchar mas no máximo 2 letras
    const es = N$('inputEstado')

    //Será executada pelo Form (da valores aleatorios para todos os campos)
    window.randomizar = e => {
        charComp.map(c => c.value = randStr(10))
        numComp.map(c => c.value = randNum(999))
        es.value = randStr(2)
    }

} `By Cold Meson_06`
