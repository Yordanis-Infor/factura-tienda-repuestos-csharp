/*

Tienda de repuestos

Una tienda de respuestos quiere automatizar su factura.Cada 
Venta lleva 18% de ITBIS y, si el cliente es frecuente, se le
descuento 10% antes de calcular el impuesto.

*/
class Automatizar
{
    static void Main()
    {
        Factura(0);
    }
    static void Factura(decimal f)
    {
        Console.WriteLine("Opcion 1: Cliente normal");
        Console.WriteLine("Opcion 2: Cliente Frecuente");

        Console.WriteLine("Numero de cuenta: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Factura: ");
        f = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
                decimal ITBIS = f * 0.18m;
                decimal total = f + ITBIS;

                Console.WriteLine($"Su factura a pagar es: {total}");
                break;

            case 2:
                decimal descuento = f * 0.10m;
                total = f - descuento;

                ITBIS = total * 0.18m;
                total = total + ITBIS;

                Console.WriteLine($"Su factura a pagar es: {total}, Su descuento aplicado es: {descuento}");
                break;

            default:
                Console.WriteLine("No existe esta opcion!");
                return;
        }

    }

}
