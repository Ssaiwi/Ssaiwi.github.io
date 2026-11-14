using System;
using System.Collections.Generic;

public class Sisallys // Yhden reseptin sisältö ja tämä pitää huolen, että hedelmä ja sen oikea ohje pysyvät yhdessä
{
    public string hedelma { get; set;} 
    public string ohje {get; set;}

    public Sisallys(string hedelma, string ohje) // tämä tallentaa hedelmän nimen ja ohjeen ja luo olion
    {
        this.hedelma = hedelma;
        this.ohje = ohje;
    }
}
public class Reseptit
    {
        private List<Sisallys> listaus = new List<Sisallys>(); // yksityinen listaus, jotta pääohjelman toiminnot eivät listausta muuta

        private int usage = 0; // laskurin lähtöasema käyttökertojen laskua varten

        public Reseptit() // listaus resepteista valmiina 
        {
        listaus.Add(new Sisallys ("apple", "APPLE PIE RECIPE \n" + "1. Prepare apples: Peel, core, and thinly slice 6-7 apples. Toss with 150 g sugar, \n" + "2 tbsp flour, 1 tsp cinnamon, and 1 tbsp lemon juice. \n" + "3. Layer pie: Fit bottom crust into a 23 cm pan and heap the apples into a high mound in the center.\n" +
        "4. Top & crimp: Cover with top dough, trim, roll the edges under, crimp to seal, and cut several vent slits. \n" + "5. Wash & shield: Brush top crust with milk or egg wash; shield edges with foil if they brown too fast during baking. \n" +
        "6. Bake: Bake at 200°C for 50 minutes until the apples are tender when pierced through a vent with a paring knife. \n"));

        listaus.Add(new Sisallys ("lime", "KEY LIME PIE \n" + "1. Bake graham crust: Mix 150 g graham cracker crumbs, 75 g melted butter, and 40 g sugar. \n" + "2. Press into a 23 cm pie dish and bake at 175°C for 8 minutes.\n" +
        "3. Whisk filling: Whisk 1 can sweetened condensed milk, 3 egg yolks, and 120 ml fresh lime juice with 1 tbsp lime zest until smooth.\n" + "4.Fill & bake: Pour the filling into the warm crust and bake at 175°C for 15 minutes until the center is set but slightly jiggles.\n" +
        "5.Chill fully: Let the pie cool completely at room temperature, then refrigerate for at least 3 hours to firm up.\n" + "6. Garnish: Top with fresh whipped cream and thin slices of lime zest before serving cold.\n"));

        listaus.Add(new Sisallys ("blueberry", "BLUEBERRY PIE\n" + "1.Prepare filling: Toss 750 g fresh or frozen blueberries with 150 g sugar, 30 g cornstarch, 15 ml lemon juice, and ¼ tsp cinnamon.\n" +
        "2.Fill crust: Line a 23 cm pie plate with rolled-out pie dough and spoon the blueberry mixture evenly into the base.\n" + "3.Cover & seal: Cover with the top crust or a lattice grid, trim excess dough, crimp the edges together, and cut steam vents.\n" +
        "4.Egg wash: Brush the top dough with an egg wash (1 egg beaten with 15 ml water) and sprinkle with coarse sugar.\n" + "5. Bake: Bake at 200°C for 50 minutes until the crust is deep golden and the berry juices bubble thickly through the vents.\n"));

        listaus.Add(new Sisallys ("rhubarb", "RHUBARB PIE\n" + "1.Mix filling: Combine 500 g chopped rhubarb (1 cm pieces) with 250 g sugar, 45 g flour, and ¼ tsp nutmeg; let sit for 10 minutes.\n" + "2. Assemble bottom: Roll out bottom pie crust, drape into a 23 cm pan,\n" + "and fill with the rhubarb mixture, dotting the top with 30 g butter.\n" +
        "3.Add top layer: Add top crust, crimp edges tight, and cut 4-5 generous slits on top to let steam escape during baking.\n" + "4.Initial high bake: Bake at 220°C for 15 minutes to set the pastry structure.\n" + 
        "5.Finish baking: Reduce heat to 190°C and bake for an additional 40 minutes until juices bubble thickly through the vents.\n"));

        listaus.Add(new Sisallys ("lemon","LEMON MERINGUE PIE\n" + "1.Blind-bake crust: Prick a 23 cm pie shell, line with parchment and weights, and bake at 190°C for 15 minutes until set.\n" +
        "2.Make lemon filling: Whisk 200 g sugar, 25 g cornstarch, 240 ml water, and 3 egg yolks in a saucepan; cook until thick, then stir in 120 ml lemon juice and 30 g butter.\n" + "3.Whip meringue: Beat 3 reserved egg whites with ¼ tsp cream of tartar, gradually adding 75 g sugar until stiff, glossy peaks form.\n" +
        "4.Assemble: Pour the warm lemon filling into the pre-baked crust and spread meringue evenly over the top, sealing completely to the crust edges.\n" + "5.Bake & cool: Bake at 175°C for 11 minutes until the meringue peaks turn golden brown, then chill thoroughly before slicing.\n"));

        listaus.Add(new Sisallys ("cherry","CLASSIC CHERRY PIE\n" + "1. Prep cherries: Toss 750 g pitted cherries with 150 g sugar, 25 g tapioca starch, 15 ml lemon juice, and ½ tsp vanilla extract.\n" + "2.Line dish: Roll out half of your double-pie crust dough and fit it into a 23 cm pie dish; pour in the cherry mixture and dot with 15 g butter.\n" +
        "3.Top pie: Roll out the top crust, place it over the filling (or cut into strips for a lattice), seal, and crimp the edges.\n" + "4.Vent & wash: Cut small ventilation slits on top and brush the crust with an egg wash (1 egg beaten with 15 ml water).\n" + 
        "5.Bake: Bake at 200°C for 20 minutes, then lower to 190°C and bake for 35 minutes until the filling bubbles vigorously.\n"));
        }

    public string GetRecipe(string fruit) // Metodilla tarkistetaan löytyykö hedelmä listauksesta
    {
        if (fruit == "limes") // monikko muutetaan yksiköksi, jotta listauksesta haku onnistuu
        {
            fruit = "lime";
        }
        else if (fruit == "apples")
        {
            fruit = "apple";
        }
        else if (fruit == "blueberries")
        {
            fruit = "blueberry";
        }
        else if (fruit == "cherries")
        {
            fruit = "cherry";
        }
        else if (fruit == "rhubarbs")
        {
            fruit = "rhubarb";
        }
        else if (fruit == "lemons")
        {
            fruit = "lemon";
        }
        foreach (Sisallys asia in listaus) // silmukka etsii listasta oikean reseptin
        {
            if (asia.hedelma == fruit)
            {
                usage++;
                return asia.ohje;

            }
        }
        return "No recipe found";
    }
    public int GetUsage()
    {
        return usage; // Metodilla lasketaan monta kertaa on onnistuneesti haettu resepti
    }
}
