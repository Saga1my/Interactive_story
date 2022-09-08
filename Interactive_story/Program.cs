Console.WriteLine("Du är hungrig och väljer att gå in i köket för att laga lite mat, du kollar efter ingredienser och konstaterar att du har tillräckligt för att laga antingen en avokado macka eller en pizza. Vad vill du laga? (Skriv pizza/macka)");
string mat = Console.ReadLine();

if (mat=="macka")
{
Console.WriteLine("Mums! Du hämtar alla ingredienser och börjar laga din macka. Mitt under matlagningen ser du en person som stirrar på din från anbdra sidan av rummet.'hallå?' säger du. Personen svarar ej utan springer istället mot dig i full hastighet. Han snor din avokado coh säger att han tänker laga en måltid till dig. Vill du att han gör det? (skriv ja/nej)");
}
string james = Console.ReadLine();

if (james=="nej")

{
    Console.WriteLine("Hans blick blir kall. Du försöker nå närmsta kniv men det är redan försent. Han kastar avokado kärnan i ditt öga och mosar in den i din hjärna. Du dör genast. Efter din död använder han dina organ för att laga mat. GAME OVER");
}

if (james=="ja")
{
Console.WriteLine("Hans ögon lyser upp. Han ber dig sätta dig ner vid bordet medans han förbereder maten. När han sedan är klar serverar han det på ett vackert fat. Du kollar ner på maträtten och tappar genast aptiten. På tallricken ligger en halv avokado, där kärnan brukade vara är det ni istället olja. Du stirrar på olje-pölen och upptäcker 3 stycken små chili flakes som flyter på ytan. Det ser hemskt ut. Han ger dig en sked och vill att du äter olje-soppan med den. Gör du det? (skriv ja/nej) ");

}

string soppa = Console.ReadLine();

if (soppa=="ja")
{
Console.WriteLine("Du dör genast av matförgiftning. GAME OVER");

}

if (soppa=="nej")

{
Console.WriteLine("Han blir arg. Han frågar om du tycker inte tycker det ser gott ut och du svarar inte. Hans respons är att skrapa ut dina ögon med skeden han ville att du skulle äta soppan med. Du blir blind men överlever. DU VANN SPELET!!");

}

if (mat=="pizza")
{
Console.WriteLine("Du lagar din pizza men sätter den sen i halsen och dör. Du glömde skära pizzan innan du började äta och försökte svälja den hel. Väldigt dumt gjort. GAME OVER!");

}







Console.ReadLine();