public class facturacionRetailmax
{
 public static void Main(string[] args)
{
 console.writeline("================================");
 console.writeline("Retailmax Facturación Electrónica");
 console.writeline("================================");
 string codigo, nombre;
 int cantidad, numProductos;
 double preciUnitario, subtotalProducto, totalBruto, totalProducto;
        // Do-While
        do
        {
            Console.WriteLine("Código del producto (0 para finalizar)");
            codigo = Console.ReadLine();
            //Condicional
            if (codigo == "0")
            {
                console.writeline("Nombre del Producto: ");
                nombre = Console.ReadLine();
                
                Console.WriteLine("Cantidad: ");
                cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Precio Unitario: ");
                preciUnitario = double.Parse(Console.ReadLine());

                //Llamado a función
                subtotalProducto = calcularSubtotal(cantidad, preciUnitario);
                totalBruto+= subtotalProducto;//Acumulador - Equivalente a totalBruto = totalBruto + subtotalProducto
                numProductos++; //Equivalente a numProductos = numProductos + 1
                
                Console.WriteLine("Subtotal del producto: " + subtotalProducto.ToString("F2"));//F2 = Formato de 2 decimales
                }
        } while (codigo != "0");
        //Llamado a funciones
        
        //Cálculos
        double montoDescuento, montoIGV, totalFinal;
}

public static double calcularSubtotal(int cantidad, double precioUnitario)
{
    double subtotal;
    subtotal = cantidad * precioUnitario;
    return subtotal;
}

//Función calcular descuento
public static double calcularDescuento(double _montoTotal)
{
    double descuento;
    if (_montoTotal > 300)
    {
        descuento = _montoTotal * 0.10; //10% de descuento
    }
    else if (_montoTotal > 200)
    {
        descuento = _montoTotal * 0.05; //5% de descuento
    }
    else
    {
        descuento = 0; //No hay descuento
    }
    return descuento;
}

//Funcion cálculo IGV
public static double calcularIGV(double monto)
{  
    double igv;
    igv = monto * 0.18; //18% de IGV
    return igv;
}

//Mostarr ticket
public static void MostrarTicket(double totalBruto, double montoDescuento, double montoIGV, double totalFinal)
{
    Console.WriteLine("================================");
    Console.WriteLine("Resumen de la Factura");
    Console.WriteLine("================================");
    Console.WriteLine("Total Bruto: " + totalBruto.ToString("F2"));
    Console.WriteLine("Monto Descuento: " + montoDescuento.ToString("F2"));
    Console.WriteLine("Monto IGV: " + montoIGV.ToString("F2"));
    Console.WriteLine("Total Final: " + totalFinal.ToString("F2"));

}
}