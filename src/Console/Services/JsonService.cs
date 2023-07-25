﻿namespace Haystac.Console.Services;

public class JsonService : IJsonService
{
    //< TODO - Add a 'FileSystemService' (https://github.com/gclodge/Haystac/issues/2)
    //< TODO - Consider migrating this to Haystac.Infrastructure along with IFileSystemService

    public async Task<T> ParseFromFile<T>(string jsonFile)
    {
        if (!File.Exists(jsonFile)) throw new FileNotFoundException($"Unable to locate: {jsonFile}");

        var json = await File.ReadAllTextAsync(jsonFile);

        var entity = JsonSerializer.Deserialize<T>(json);
        if (entity == null) throw new Exception($"Failed to parse {nameof(T)} from: {jsonFile}");

        return entity;
    }
}
