//Tax program calculator
//There is no taxation for any amount lower than 1000
//Income tax is 10% after any dollar gained after 1000
//After income tax you have to pay social tax, 15% after 1000 and after paying regular tax
//social contribution can not excede 3000 total, regular taxes have no limit
//example one, 800 salary pays no taxes and no social contribution
//example two, 3400 salary, first it gets deducted 10% of everything gained after the first 1000
//(10 % of 3400 - 1000 = 240) and then you pay social tax for net income
//(15% of (3400 - 1000 - 10% = 2000) = 300 )
// Declare variables and then initialize to zero.

// Display title as the C# console calculator app.
Console.WriteLine("Tax income calculator by Guillermo Lorca\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Type your net income");
double GrossIncome = Convert.ToDouble(Console.ReadLine());
double taxable = GrossIncome - 1000;
double socialTax = GrossIncome - 1000 > 2000 ? 2000 - (2000 * 0.85) : taxable - (taxable * 0.85);

// Console.WriteLine(socialTax);

GrossIncome = GrossIncome > 1000 ?
 (GrossIncome - (taxable - (taxable * 0.9))) - socialTax
 : GrossIncome;
// if (GrossIncome >= 1000)
// {
//     double taxableIncome = GrossIncome - ((GrossIncome - 1000) * 0.10);
//     Console.WriteLine(taxableIncome);
//     double socialTax = taxableIncome * 0.85;
//     Console.WriteLine(socialTax);
//     GrossIncome = 1000 + socialTax;
// }
Console.WriteLine("Your gross income is... " + GrossIncome);
// Wait for the user to respond before closing.
Console.Write("Press any key to close the app");
Console.ReadKey();
Console.WriteLine();