int location_x, location_y;
string enemy_location = " ";

Console.Write("Digite a coordenada X: ");
location_x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a coordenada Y: ");
location_y = Convert.ToInt32(Console.ReadLine());

if(location_x < 0 && location_y > 0)
    enemy_location = "The enemy is to the Northwest";
else if(location_x < 0 && location_y == 0)
    enemy_location = "The enemy is to the West";
else if(location_x < 0 && location_y < 0)
    enemy_location = "The enemy is to the Southwest";
else if(location_x == 0 && location_y > 0)
    enemy_location = "The enemy is to the North ";
else if(location_x == 0 && location_y == 0)
    enemy_location = "The enemy is here!";
else if(location_x == 0 && location_y < 0)
    enemy_location = "The enemy is to the South";
else if(location_x > 0 && location_y > 0)
    enemy_location = "The enemy is to the Northeast";
else if(location_x > 0 && location_y == 0)
    enemy_location = "The enemy is to the East";
else if(location_x > 0 && location_y < 0)
    enemy_location = "The enemy is to the Southeast";


Console.WriteLine(enemy_location);