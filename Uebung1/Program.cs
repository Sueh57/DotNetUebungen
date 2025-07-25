using Uebung1.Domain;

//ChatGPT sagt very easy: Du erstellst ein neues Auto (vom Typ Mercedes) und speicherst es in der Variable myMercedes.
// ChatGPT besser: Du erzeugst eine Instanz der Klasse Mercedes – also ein Objekt – und speicherst es in der Variable myMercedes.

// Mit new Mercedes hast du eine Instanz der Klasse Mercedes erstellt.
// Damit hast du ein Objekt
// Das Objekt weist du der Variable myMercedes vom Typ Auto zu.
Auto myMercedes = new Mercedes("Rot", 100);
myMercedes.AnzahlTueren = 5;

Auto myMercedes2 = new Mercedes("Gelb", 1000);
myMercedes2.AnzahlTueren = 1;

Auto myAudi = new Audi("Gelb", 200);
myAudi.AnzahlTueren = 10;

int yesso = 10;

Console.WriteLine("Mein Mercedes hat die farbe " + myMercedes.Farbe);
Console.WriteLine("Mein Mercedes2 hat die farbe " + myMercedes2.Farbe);
Console.WriteLine("Mein Audi hat die farbe " + myAudi.Farbe);

