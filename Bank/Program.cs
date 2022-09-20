using System.ComponentModel;
using Microsoft.Win32.SafeHandles;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.InteropServices;
using System.Net.Sockets;
//namespace Bank;

Kund sofiaAndersson = new Kund();
sofiaAndersson.namn = "Sofia Andersson";
sofiaAndersson.personnummer = "200404042004";
sofiaAndersson.kontonummer = 123456;

Konto sofiaAnderssonKonto = new Konto();
sofiaAnderssonKonto.ägare = sofiaAndersson;
sofiaAnderssonKonto.saldo = 1000;
sofiaAnderssonKonto.senasteTransaktion = 150;

sofiaAnderssonKonto.saldo = -20;

System.Console.WriteLine(sofiaAnderssonKonto.saldo);

Console.ReadLine();
