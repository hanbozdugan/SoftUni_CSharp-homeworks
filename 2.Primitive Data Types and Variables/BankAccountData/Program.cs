using System;
class BankAccountData
{
    static void Main()
    {
        string holderFirstName;
        string holderMiddleName;
        string holderLastName;
        decimal balance;
        string bankName;
        string IBAN;
        string BIC_Code;
        long creditCardNumber1;
        long creditCardNumber2;
        long creditCardNumber3;

        holderFirstName = "Иван";
        holderMiddleName = "Кузманов";
        holderLastName = "Иванов";
        balance = 18000M;
        bankName = "Общинска Банка АД";
        IBAN = "BG85STSA12345678912345";
        BIC_Code = "STSABGSF";
        creditCardNumber1 = 4657585892929299;
        creditCardNumber2 = 9764646565656564;
        creditCardNumber3 = 1423637484595073;

        Console.WriteLine("Име,Презиме,Фамилия: {0} {1} {2}\nБаланс: {3}лв.\nИме на Банката: {4}\nIBAN: {5}\nBIC: {6}\nКредитна карта Maestro: {7}\nКредитна карта Visa:    {8}\nДебитна карта:          {9}", holderFirstName, holderMiddleName, holderLastName, balance, bankName, IBAN, BIC_Code, creditCardNumber1, creditCardNumber2, creditCardNumber3);
    }
}
