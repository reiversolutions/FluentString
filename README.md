# Fluent String

`String.IsNullOrWhiteSpace(String value)` is now an extension method of `string`.

-------------------------------------------------------------------------------

With FluentString the following are identical;

```c#
String.IsNullOrWhiteSpace("Test string");
"Test string".IsNullOrWhiteSpace();
```

-------------------------------------------------------------------------------

## Methods

### IsNullOrWhiteSpace

Checks that a `string` is not Null, Empty or just White-space

```c#
"Test string".IsNullOrWhiteSpace();
```

### IsNullOrWhiteSpaceOrDefault

Checks that a `string` is not Null, Empty, just White-space or an expected default.

```c#
"Test string".IsNullOrWhiteSpaceOrDefault(Guid.Empty.ToString());
```