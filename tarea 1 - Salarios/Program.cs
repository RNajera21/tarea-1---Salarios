//Tarea 2 Salarios - Progra

double salario = 0;
double salhr = 45;
double salarioaumentado = 0;
double aumento = 0;
double salariobruto = 0;
double deduccion = 9.17;
double neto = 0;
double totaumento = 0;
double totdeduccion = 0; //Definiciones.

Console.WriteLine("Por favor ingrese el nombre a consultar");
string nombre = Console.ReadLine();
Console.WriteLine("Por favor ingrese su cedula");
string cedula = Console.ReadLine();
Console.WriteLine("Nombre a consultar: {0}. Cedula: {1}", nombre, cedula);
Console.WriteLine("Ingrese el codigo de empleado"); // Recoleccion de datos
int tipo = int.Parse(Console.ReadLine());
if (tipo == 1)
    aumento = salhr * 0.15;
if (tipo == 2)
    aumento = salhr * 0.10;
if (tipo == 3)
    aumento = salhr * 0.05; // Ciclo para determinar código de aumento salarial
Console.WriteLine("Ingrese el numero de horas laboradas");
double hrslab = double.Parse(Console.ReadLine()); // Recoleccion de hrs laboradas

salario = hrslab * salhr;
totaumento = salhr + aumento;
salariobruto = salario + totaumento;
totdeduccion = salariobruto / deduccion;
neto = salariobruto - totdeduccion; // Formulas


Console.WriteLine("Nombre: {0}. Cédula: {1}. Código de Empleado: {2} Salario/hora: {3}. Horas laboradas: {4}. Salario: {5}. Salario/Hr despues de Aumento: {6}. Bruto: {7}. CCSS: {8}. Neto: {9}.", nombre, cedula, tipo, salhr, hrslab, salario, totaumento, salariobruto, totdeduccion, neto); // Output



