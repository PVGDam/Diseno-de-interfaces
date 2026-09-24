//Se debe desarrollar un programa que 
//tenga las siguientes responsabilidades: -Ingresar una fórmula que contenga paréntesis,
//corchetes y llaves. - Validar que los ( ) [] y { }
//estén correctamente balanceados.

//Ejemplo de fórmula: (2 + [3 - 12] *{ 8 / 3})

Stack<char> pila = new Stack<char>();

var formula = "(2 + [3 - 12] *{ 8 / 3})";
bool correcto = true;

var simbolos = new Dictionary<char, char> {

    { ')', '('},
    { ']', '['},
    { '}', '{'},
};

foreach (char c in formula)
{
    if (c == '(' | c == '[' | c == '{') {
        pila.Push(c);
    } else if (simbolos.ContainsKey(c)) {
        if (!pila.TryPop(out char apertura) || apertura != simbolos[c]) {
            correcto = false;
            break;
        }
    }
}

if (pila.Count > 0) {
    correcto = false;
}

Console.WriteLine(correcto ? "La formula esta bien formada." : "La formula esta mal formada.");