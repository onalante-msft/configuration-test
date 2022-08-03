using Microsoft.Extensions.Configuration;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables()
    .Build();

bool? first = configuration.GetValue<bool?>("FOO");
bool? second = configuration.GetValue<bool?>("BAR");
bool third = configuration.GetValue<bool>("BAZ", false);
Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine(third);
Console.WriteLine(first ?? second ?? third);
