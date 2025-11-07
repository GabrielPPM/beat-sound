string appName = @" ____             _    _____                       _ 
|  _ \           | |  / ____|                     | |
| |_) | ___  __ _| |_| (___   ___  _   _ _ __   __| |
|  _ < / _ \/ _` | __|\___ \ / _ \| | | | '_ \ / _` |
| |_) |  __/ (_| | |_ ____) | (_) | |_| | | | | (_| |
|____/ \___|\__,_|\__|_____/ \___/ \__,_|_| |_|\__,_|
                                                     ";
string greetingsMessage = $"Boas-vindas ao BeatSound!";
string selectedOption = "";

void sectionMessage(string title, string text)
{
    Console.WriteLine($"{title}");
    Console.WriteLine($"{text}\n");
}

void menuOptions()
{
    Console.WriteLine(@"Digite:

    1 - para registrar uma banda 
    2 - para mostrar todas as bandas
    3 - para avalidar uma banda
    4 - para exibir a média de uma banda
    0 - para sair
    ");
}


sectionMessage(appName, greetingsMessage);
menuOptions();
selectedOption = Console.ReadLine()!;