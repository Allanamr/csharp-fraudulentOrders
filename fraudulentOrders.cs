/* Programa que recorre una matriz para detectar ordenes fraudulentas en pedidos realizados,
teniendo en cuenta que las que empiezan en B tienen alta posibilidad de que puedan ser fraudulentas.
Se crea un bucle foreach para recorrer la matriz en busca de las ordenes que empiecen con la letra
"B", y posterior a esto se imprimen estas ordenes almacenadas en la matriz.*/

string[] fraudulentOrdersIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
foreach (string frecuentFraudulent in fraudulentOrdersIDs)
{
    if (frecuentFraudulent.StartsWith("B"))
    {
        Console.WriteLine($"The order {frecuentFraudulent} is probably a fraudulent order, please check");
    }
}