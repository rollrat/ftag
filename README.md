# ftag

![Image](docs/logo.png)

ftag is file tag manager.
With this program, you can organize your files by tagging them.

## Library

### FTagStream

`FTagStream` is file-io stream that accesss `.ftag` file.
All tags are managed by that is created in the selected folder.
`FTagStream` implements all the functions provided by the library.
The following code snippet shows how to add and delete tags.

``` csharp
/// make .ftag file
FTagStream stream = new FTagStream(@"D:\Manage"); 

/// Add tags that array of {"Money", "Document", "ASAP"}
stream["AccountBook.xlsx"] = "Money, Document, ASAP";

/// Delete whole tags from files.
stream["AccountBook.xlsx"] = "";
```

You can also get simple statistics about the tags.

``` csharp
/// Get array in descending order.
foreach (var tuple in stream.GetTagRank())
    out.Append($"Tags: {tuple.Item1}, Count: {tuple.Item2}");
```

You can use the `SearchTag` function to search for files with specific tags.

``` csharp
List<string> andTags;
List<string> orTags;
List<string> notTags;

foreach (FTagObject obj in stream.SearchTag(andTags, orTags, notTags))
    out.Append(obj.SubPath);
```