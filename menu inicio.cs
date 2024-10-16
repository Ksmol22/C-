using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;

        while (opcion != 13)
        {
            MostrarMenu();
            Console.Write("Elija una opción (1-13): ");
            
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        CalculoInteresBancario();
                        break;
                    case 2:
                        CalculoSueldoVendedor();
                        break;
                    case 3:
                        ConversionPesosADolares();
                        break;
                    case 4:
                        CalculoIncrementoSalarial();
                        break;
                    case 5:
                        CalculoPrecioVenta();
                        break;
                    case 6:
                        NumeroMayorDeTres();
                        break;
                    case 7:
                        DeterminarPositivoNegativoNeutro();
                        break;
                    case 8:
                        CalculoCostoLapices();
                        break;
                    case 9:
                        CalculoDescuentoPorClave();
                        break;
                    case 10:
                        CalculoMatriculaConDescuento();
                        break;
                    case 11:
                        DescuentosTeatroPorEdad();
                        break;
                    case 12:
                        ControlPesoClubObesidad();
                        break;
                    case 13:
                        Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija un número del 1 al 13.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

            if (opcion != 13)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("=== Menú de Ejercicios ===");
        Console.WriteLine("1. Cálculo de interés bancario");
        Console.WriteLine("2. Cálculo de sueldo de vendedor");
        Console.WriteLine("3. Conversión de pesos a dólares");
        Console.WriteLine("4. Cálculo de incremento salarial");
        Console.WriteLine("5. Cálculo de precio de venta");
        Console.WriteLine("6. Número mayor de tres");
        Console.WriteLine("7. Determinar si un número es positivo, negativo o neutro");
        Console.WriteLine("8. Cálculo del costo de lápices");
        Console.WriteLine("9. Cálculo de descuento por clave");
        Console.WriteLine("10. Cálculo de matrícula con descuento");
        Console.WriteLine("11. Descuentos en teatro por edad");
        Console.WriteLine("12. Control de peso en club contra obesidad");
        Console.WriteLine("13. Salir");
        Console.WriteLine("===========================");
    }

    // ---------------------------------------------------------------------------
    static void CalculoInteresBancario()
    {
        Console.WriteLine("Cálculo de interés bancario");
        

        // Paso 1: Pedir al usuario que ingrese el capital
        Console.Write("Ingrese el capital a invertir: ");
        double capital = Convert.ToDouble(Console.ReadLine());

        // Paso 2: Definir la tasa de interés (2% mensual = 0.02)
        double tasaInteres = 0.02;

        // Paso 3: Calcular la ganancia
        double ganancia = capital * tasaInteres;

        // Paso 4: Mostrar el resultado
        Console.WriteLine("La ganancia después de un mes será: " + ganancia);

        // Esperar a que el usuario presione una tecla antes de cerrar
        Console.ReadKey();
    }
    // ---------------------------------------------------------------------------
    static void CalculoSueldoVendedor()
    {
        Console.WriteLine("Cálculo de sueldo de vendedor");
        // Ejercicio 2: Cálculo de sueldo de vendedor
        Console.WriteLine("Cálculo de sueldo de vendedor");

        // Paso 1: Pedir el sueldo base
        Console.Write("Ingrese el sueldo base del vendedor: ");
        double sueldoBase = Convert.ToDouble(Console.ReadLine());

        // Paso 2: Pedir los montos de las tres ventas
        Console.Write("Ingrese el monto de la primera venta: ");
        double venta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el monto de la segunda venta: ");
        double venta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el monto de la tercera venta: ");
        double venta3 = Convert.ToDouble(Console.ReadLine());

        // Paso 3: Calcular el total de ventas
        double totalVentas = venta1 + venta2 + venta3;

        // Paso 4: Calcular la comisión (10% del total de ventas)
        double comision = totalVentas * 0.10;

        // Paso 5: Calcular el sueldo total
        double sueldoTotal = sueldoBase + comision;

        // Paso 6: Mostrar los resultados
        Console.WriteLine("Comisión por ventas: " + comision);
        Console.WriteLine("Sueldo total del mes: " + sueldoTotal);

        Console.ReadKey();
    }
    
    // ---------------------------------------------------------------------------
    static void ConversionPesosADolares()
    {
        
        // Ejercicio 3: Conversión de pesos a dólares
        Console.WriteLine("Conversión de pesos a dólares");

        // Paso 1: Pedir la cantidad en pesos
        Console.Write("Ingrese la cantidad en pesos: ");
        double pesos = Convert.ToDouble(Console.ReadLine());

        // Paso 2: Pedir el tipo de cambio
        Console.Write("Ingrese el tipo de cambio (pesos por dólar): ");
        double tipoCambio = Convert.ToDouble(Console.ReadLine());

        // Paso 3: Calcular la equivalencia en dólares
        double dolares = pesos / tipoCambio;

        // Paso 4: Mostrar el resultado
        Console.WriteLine("La cantidad en dólares es: " + dolares);

        Console.ReadKey();
    }
    // ---------------------------------------------------------------------------
    static void CalculoIncrementoSalarial()
    {
        // Ejercicio 4: Cálculo de incremento salarial
        Console.WriteLine("Cálculo de incremento salarial");

        // Paso 1: Pedir el salario anterior
        Console.Write("Ingrese el salario anterior: ");
        double salarioAnterior = Convert.ToDouble(Console.ReadLine());

        // Paso 2: Calcular el incremento (25% del salario anterior)
        double incremento = salarioAnterior * 0.25;

        // Paso 3: Calcular el nuevo salario
        double nuevoSalario = salarioAnterior + incremento;

        // Paso 4: Mostrar el resultado
        Console.WriteLine("El nuevo salario es: " + nuevoSalario);

        Console.ReadKey();
    }
    // ---------------------------------------------------------------------------
    static void CalculoPrecioVenta()
    {
        // Ejercicio 5: Cálculo de precio de venta
        Console.WriteLine("Cálculo de precio de venta");

        // Paso 1: Pedir el precio de compra
        Console.Write("Ingrese el precio de compra del artículo: ");
        double precioCompra = Convert.ToDouble(Console.ReadLine());

        // Paso 2: Calcular la ganancia (30% del precio de compra)
        double ganancia = precioCompra * 0.30;

        // Paso 3: Calcular el precio de venta
        double precioVenta = precioCompra + ganancia;

        // Paso 4: Mostrar el resultado
        Console.WriteLine("El precio de venta debe ser: " + precioVenta);

        Console.ReadKey();
    }
    // ---------------------------------------------------------------------------
    static void NumeroMayorDeTres()
    {
        // Ejercicio 1: Hallar el número mayor de tres números
        Console.WriteLine("Hallar el número mayor de tres números");

        // Paso 1: Pedir los tres números
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        // Paso 2: Comparar los números y determinar el mayor
        double mayor;

        if (num1 >= num2 && num1 >= num3)
        {
            mayor = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            mayor = num2;
        }
        else
        {
            mayor = num3;
        }

        // Paso 3: Mostrar el resultado
        Console.WriteLine("El número mayor es: " + mayor);

        Console.ReadKey();
    }
    // ---------------------------------------------------------------------------
    static void DeterminarPositivoNegativoNeutro()
    {
        // Ejercicio 2: Determinar si un número es positivo, negativo o neutro
        Console.WriteLine("Determinar si un número es positivo, negativo o neutro");

        // Paso 1: Pedir el número
        Console.Write("Ingrese un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        // Paso 2: Determinar si es positivo, negativo o neutro
        if (numero > 0)
        {
            Console.WriteLine("El número es positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El número es negativo");
        }
        else
        {
            Console.WriteLine("El número es neutro (cero)");
        }

        Console.ReadKey();
    }
    // ---------------------------------------------------------------------------
    static void CalculoCostoLapices()
    {
        // Ejercicio 3: Cálculo del costo de lápices
        Console.WriteLine("Cálculo del costo de lápices");

        // Paso 1: Pedir la cantidad de lápices
        Console.Write("Ingrese la cantidad de lápices a comprar: ");
        int cantidadLapices = Convert.ToInt32(Console.ReadLine());

        // Paso 2: Determinar el precio por lápiz
        double precioLapiz;
        if (cantidadLapices >= 1000)
        {
            precioLapiz = 150;
        }
        else
        {
            precioLapiz = 250;
        }

        // Paso 3: Calcular el total a pagar
        double totalPagar = cantidadLapices * precioLapiz;

        // Paso 4: Mostrar el resultado
        Console.WriteLine("El total a pagar es: " + totalPagar);

        Console.ReadKey();
    
}
    // ---------------------------------------------------------------------------
    static void CalculoDescuentoPorClave()
    {
        // Ejercicio 4: Cálculo de descuento por clave
        Console.WriteLine("Cálculo de descuento por clave");

        // Paso 1: Pedir los datos del artículo
        Console.Write("Ingrese el nombre del artículo: ");
        string nombreArticulo = Console.ReadLine();

        Console.Write("Ingrese la clave (01 o 02): ");
        string clave = Console.ReadLine();

        Console.Write("Ingrese el precio original: ");
        double precioOriginal = Convert.ToDouble(Console.ReadLine());

        // Paso 2: Calcular el descuento
        double descuento = 0;
        if (clave == "01")
        {
            descuento = precioOriginal * 0.10; // 10% de descuento
        }
        else if (clave == "02")
        {
            descuento = precioOriginal * 0.20; // 20% de descuento
        }

        // Paso 3: Calcular el precio con descuento
        double precioConDescuento = precioOriginal - descuento;

        // Paso 4: Mostrar los resultados
        Console.WriteLine("Artículo: " + nombreArticulo);
        Console.WriteLine("Clave: " + clave);
        Console.WriteLine("Precio original: " + precioOriginal);
        Console.WriteLine("Precio con descuento: " + precioConDescuento);

        Console.ReadKey();
    }
    // ---------------------------------------------------------------------------
    static void CalculoMatriculaConDescuento()
    {
        // Ejercicio 5: Cálculo de matrícula con descuento
        Console.WriteLine("Cálculo de matrícula con descuento");

        // Paso 1: Definir el valor de la matrícula
        double valorMatricula = 3500000;

        // Paso 2: Pedir el promedio del aprendiz
        Console.Write("Ingrese el promedio del aprendiz: ");
        double promedio = Convert.ToDouble(Console.ReadLine());

        // Paso 3: Calcular el valor a pagar
        double valorPagar;
        if (promedio >= 4.5)
        {
            // 30% de descuento, sin IVA
            valorPagar = valorMatricula * 0.70;
        }
        else
        {
            // Sin descuento, con 10% de IVA
            valorPagar = valorMatricula * 1.10;
        }

        // Paso 4: Mostrar el resultado
        Console.WriteLine("El valor a pagar es: " + valorPagar);

        Console.ReadKey();
    }
    // ---------------------------------------------------------------------------
    static void DescuentosTeatroPorEdad()
    {
        // Ejercicio 1: Descuentos en teatro por edad
        Console.WriteLine("Descuentos en teatro por edad");

        // Paso 1: Definir variables
        double precioEntrada = 10000; // Precio base de la entrada
        int cantidadClientes;
        double totalDescuentos = 0;

        // Paso 2: Pedir la cantidad de clientes
        Console.Write("Ingrese la cantidad de clientes: ");
        cantidadClientes = Convert.ToInt32(Console.ReadLine());

        // Paso 3: Ciclo para procesar cada cliente
        for (int i = 1; i <= cantidadClientes; i++)
        {
            Console.Write("Ingrese la edad del cliente " + i + ": ");
            int edad = Convert.ToInt32(Console.ReadLine());

            double descuento = 0;

            // Paso 4: Calcular descuento según la edad
            if (edad < 5)
            {
                Console.WriteLine("Los menores de 5 años no pueden entrar al teatro.");
                continue;
            }
            else if (edad >= 5 && edad <= 14)
            {
                descuento = precioEntrada * 0.35;
            }
            else if (edad >= 15 && edad <= 19)
            {
                descuento = precioEntrada * 0.25;
            }
            else if (edad >= 20 && edad <= 45)
            {
                descuento = precioEntrada * 0.10;
            }
            else if (edad >= 46 && edad <= 65)
            {
                descuento = precioEntrada * 0.25;
            }
            else
            {
                descuento = precioEntrada * 0.35;
            }

            totalDescuentos += descuento;
        }

        // Paso 5: Mostrar el resultado
        Console.WriteLine("El teatro dejó de percibir en total: " + totalDescuentos);

        Console.ReadKey();
    }
    // ---------------------------------------------------------------------------
  
    static void ControlPesoClubObesidad()
    {
        Console.WriteLine("Control de peso en club contra obesidad");
        // Paso 1: Definir variables
        int cantidadMiembros = 5;
        int cantidadBasculas = 10;

        // Paso 2: Ciclo para cada miembro
        for (int miembro = 1; miembro <= cantidadMiembros; miembro++)
        {
            Console.WriteLine("\nMiembro " + miembro);

            // Paso 3: Pedir el peso anterior
            Console.Write("Ingrese el peso anterior: ");
            double pesoAnterior = Convert.ToDouble(Console.ReadLine());

            double sumaPesos = 0;

            // Paso 4: Ciclo para cada báscula
            for (int bascula = 1; bascula <= cantidadBasculas; bascula++)
            {
                Console.Write("Ingrese el peso en la báscula " + bascula + ": ");
                double pesoBastula = Convert.ToDouble(Console.ReadLine());
                sumaPesos += pesoBastula;
            }

            // Paso 5: Calcular el promedio de peso actual
            double promedioActual = sumaPesos / cantidadBasculas;

            // Paso 6: Calcular la diferencia de peso
            double diferencia = promedioActual - pesoAnterior;

            // Paso 7: Mostrar el resultado
            if (diferencia > 0)
            {
                Console.WriteLine("SUBIO " + diferencia + " kilos");
            }
            else if (diferencia < 0)
            {
                Console.WriteLine("BAJO " + Math.Abs(diferencia) + " kilos");
            }
            else
            {
                Console.WriteLine("Se mantuvo en el mismo peso");
            }
        }

        Console.ReadKey();
    }
}
