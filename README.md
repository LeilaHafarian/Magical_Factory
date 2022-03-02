# Magical_Factory
I should build a factory that can manufacture products based on different drawings. The drawing used is decided based on what is sent to the factory. It is thus not the user who decides what the factory should do, but the factory builds the product that best suits the material that is sent in...
På svenska:
Den magiska fabriken
I den här uppgiften ska du bygga en fabrik som kan tillverka produkter utifrån olika ritningar. Vilken ritning som används avgörs baserat på vad som skickas in till fabriken. Det är alltså inte användaren som avgör vad fabriken ska göra utan fabriken bygger den produkt som bäst passar det material som skickas in.
Exempel. Skickar användaren in en bit gummi och en bit metall kommer fabriken producera ett hjul.
En producerad del kan skickas in till fabriken igen tillsammans med andra material för att producera en mer komplex produkt. Till exempel om användaren skickar in 4 hjul och 2 bitar metall producerar fabriken en bil.
Användaren ska ha ett lager med material och tidigare producerade produkter. Programmet ska låta användaren välja ett antal saker från lagret som sen skickas in i fabriken. Fabriken förbrukar materialet som skickas in så säkerställ att materialet inte ligger kvar i lagret samtidigt som det skickas till maskinen.
Om användaren skickar med material som inte används av maskinen ska de skickas tillbaka tillsammans med den producerade produkten. Detsamma gäller om maskinen inte kan matcha materialet mot en ritning. Då ska allt material skickas tillbaka oförändrat.
Programmet tar aldrig slut men efter ett tag kommer användaren ha använt upp hela sitt lager material och de producerade produkter som finns i lagret går inte att förädla mer.
För att hjälpa dig på vägen har vi delat upp uppgiften i flera delmoment
Del 1 – program-loopen
När vi bygger en applikation kan vi antingen börja med de minsta beståndsdelarna och bygga applikationen lager för lager runt dem. Eller börja med gränssnittet mot användaren. Medan vi bygger gränssnittet inser vi vilken information vi behöver i systemet och vilken information vi behöver från användaren och från det kan vi steg för steg bygga applikationen utifrån våra identifierade behov.
Att bygga från de minsta beståndsdelarna kan funka bra om man har en tydlig bild av hur domänen vi försöker bygga applikationen i fungerar. Ska vi däremot bygga en applikation där vi är osäkra på vad vi ska bygga är det ofta bättre att börja med gränssnittet.
Med det i åtanke föreslår jag att ni börjar här i del 1 med att bygga gränssnittet och vänta med själva fabriken tills ni vet mer vad ni behöver i applikationen. En teknik som kan vara användbar här är att skapa upp klasser och deras metoder utan att skriva någon kod i metoderna. På så sätt kan vi prototypa applikationen och se om hur de olika klasserna samspelar.
 
Bestäm själva hur gränssnittet ska se ut. Som lite inspiration tänker vi oss något åt det här hållet.
 
Bilden ovan är hårdkodad (det är bara strängar jag skrivit ut med Console.WriteLine()) jag skapade den för att få en känsla för vilken typ av klasser vi kan tänkas behöva och hur de ska kopplas samman.
Från bilden ser jag att lagret listar olika material. Redan i den meningen har vi tre ord av intresse. Vi kanske kan ha en klass för vårt lager? Vi kanske kan ha en klass för Material? Vi kommer i och för sig ha olika typer av material. Det kanske är läge för en abstrakt klass eller ett interface. Oavsett hur vi väljer att representera materialen så ska vi lista dem. Så vi behöver förmodligen en List av material.
Stycket ovan försöker förklara hur vi kan nysta ut vilka delar vi behöver i applikationen utifrån gränssnittet användaren ser. Se det som en inspiration till ert eget arbete.
Denna del av uppgiften är klar när:
•	Vi kan lista innehållet i lagret
•	Välja ut vilka material som ska skickas till fabriken
•	Skicka valt material till fabriken (fabriken ska inte göra något med materialet. Det räcker att ni gör en WriteLine eller liknande för att markera att användarens input tagits emot
Del 2 – Den magiska maskinen
Nu är det dags att bygga själva kärnan i applikationen. Vi vet från uppgiftsbeskrivningen och del 1 att vi vill skicka in en lista med material och få tillbaka en lista med material. Så rimligtvis ska vi ha en klass som har en metod som tar en lista med material och returnerar en lista med material. Det kan vara en bra utgångspunkt.
Beskrivningen i början av uppgiften beskriver maskinens beteende men vi kan förtydliga lite mer här
•	Materialet som skickas in ska matchas mot alla ritningar i maskinen
•	Materialet som skickas in ska tas bort från användarens lager
•	En ritning har krav på vilket material den behöver för att producera sin produkt
•	En ritning matchar en lista med material om listan innehåller allt material ritningen behöver
•	Om maskinen hittar en ritning som matchar materialet
o	Så ska produkten ritningen beskriver produceras
o	Den producerade produkten ska skickas tillbaka till användarens lager
o	Material som skickats till maskinen men som inte behövs av ritningen ska skickas tillbaka till användarens lager
•	Om maskinen inte hittar en ritning som matchar ska allt material skickas tillbaka oförändrat
•	Om flera ritningar matchar ska den som använder flest delar från materiallistan användas
•	Om flera ritningar matchar och de använder lika många delar från materiallistan ska den första ritningen som matchar användas
Vi har inga direkta krav på vilka ritningar som ska finnas i maskinen utan vi lämnar det till er fantasi. Har ni ingen fantasi föreslår vi att ni lägger in recepten för hjul och bil som beskrevs i uppgiftsbeskrivningen ovan.
Se även till att det som returneras från fabriken läggs till i användarens lager. Med detta på plats borde ni ha en fullt fungerande fabrik.
Del 3 – Bonus
Om ni har tid och lust kan ni bygga ut maskinen med fler ritningar och fler material.
Prova till exempel att lägga på egenskaper på materialen. Vi kan ha olika typer av metaller som alla går att använda i samma ritningar men påverkar resultatet. I stället för metall och gummi kan användaren skicka in ”metall (guld) och gummi och få tillbaka en ”hjul (guld)”.
