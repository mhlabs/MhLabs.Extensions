# MhLabs.Extensions

Collection of extension / helper methods System types.

## StringExtensions.cs
```string.ToUri()```
creates a Uri from string.

Throws `UriFormatException`

Example:
```
var uri = "https://api.mathem.io/api".ToUri();
```

```string.To<T>()```
creates an object T from json string.

Throws `JsonReaderException`

Example:
```
var order = jsonString.To<Order>();
```

```string.Truncate(maxLength)```
truncates a string to its max length

Throws `ArgumentOutOfRangeException`

Example:
```
var newString = oldString.Truncate(10);


## OrderExtensions.cs
```object.ToJson()```
creates an object T from json string.

Example:
```
var order = new Order { ... }
var json = order.ToJson();
```

## Env.cs
```Env.Get(key)```
Short hand for Environment.GetEnvironmentVariable(key);

Example:
```
var apiUrl = Env.Get(ApiBaseUrl);
```


## CollectionExtension.cs
```IEnumerable.IsNullOrEmpty()```
returns true if collection is null or empty

```IEnumerable.GetChunks(chunkSize)```
returns a IEnumerable of IEnumerable chunks
