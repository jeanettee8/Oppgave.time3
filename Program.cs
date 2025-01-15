DateTime second = DateTime.Now;

// fortune cookie sayings from: https://l.messenger.com/l.php?u=https%3A%2F%2Fwww.best-ever-cookie-collection.com%2Ffortune-cookie-sayings.html&h=AT02hDup6cpAC8dGkEEhPKNee62SsLuoKM1JDk0Dd0J-E_rgT_-65wPBd_RdBCp-y30v9mA5LGGMOWZJj99jIeU8v1C_oI2OEwy2oOp2wfeOIx40McwBgWc5VGYzVlhBiO-biA

if (second.Second >= 0 && second.Second < 10) {
    Console.WriteLine("Do not be afraid of competition.");
}

else if (second.Second >= 10 && second.Second < 20) {
    Console.WriteLine("An exciting opportunity lies ahead of you.");
}

else if (second.Second >= 20 && second.Second < 30) {
    Console.WriteLine("Experience is the best teacher.");
}

else if (second.Second >= 30 && second.Second < 40) {
    Console.WriteLine("Expect the unexpected.");
}

else if (second.Second >= 40 && second.Second < 50){
    Console.WriteLine("Bloom where you are planted.");
}

else if (second.Second >= 50) {
    Console.WriteLine("Help! I'm being held prisoner in a fortune cookie factory!");
}

else {
    Console.WriteLine("Error");
}