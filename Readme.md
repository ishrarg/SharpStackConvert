# SharpStackConvert

## Overview

The SharpStackConvert NuGet package provides a set of extension methods and static class methods for easy conversion of various data types. This document summarizes the classes and methods available in the package.

## Classes

### `TypeConverter`

Contains methods for converting objects to various data types.

- `ToDecimal(object input): decimal`
- `ToDouble(object input): double`
- `CString(object input): string`
- `ToInt32(object input): int`
- `ToInt64(object input): long`
- `ToBool(string input): bool`
- `ToBool(object input): bool`
- `ToDateTime(object input): DateTime`
- `ToInt16(object input): short`
- `ToByte(object input): byte`
- `ToFloat(object input): float`
- `ToGuid(object input): Guid`

### `Base64Converter`

Contains methods for encoding and decoding strings and images using Base64.

- `ToBase64(string input, Encoding encoding): string`
- `FromBase64(string input, Encoding encoding): string`
- `ToBase64(string input): string`
- `ImageToBase64(Bitmap bitmap): string`
- `FromBase64ToBitmap(string input): Bitmap`
- `FromBase64(string input): string`
- `ToBase64(byte[] input): string`
- `FromBase64ToByteArray(string input): byte[]`
- `FromBase64ToByteArray(string input, Encoding encoding): byte[]`

### `CSVConverter`

Provides methods for handling CSV (Comma-Separated Values) data.

- `ToCSVFormat(List<string[]> rows, string splitter = ","): string`
- `ToCSVFormat(string[,] rows, string splitter = ","): string`
- `ToCSVFormat(string[][] rows, string splitter = ","): string`
- `SplitLines(string input, bool skipEmptyLines): List<string>`
- `CSVToTable(string CSVData, string tableName, bool firstLineIsHeader, char columnSplitter): DataTable`

### `DataTableConverter`

Offers methods for converting various string arrays and lists to DataTable objects.

- `ToTable(string[][] rows): DataTable`
- `ToTable(string[,] rows): DataTable`
- `ToTable(string[] rows): DataTable`
- `ToTable(string[] rows, string tableName): DataTable`
- `ToTable(string[,] rows, bool firstRowIsHeader): DataTable`
- `ToTable(List<string[]> rows, bool firstRowIsHeader, string tableName): DataTable`

### `HashConverter`

Static class providing methods for converting data into hash values (MD5, SHA1, SHA256, SHA384, SHA512).

- `ToMD5(string input, Encoding encoding): string`
- `ToSHA1(string input, Encoding encoding): string`
- `ToSHA256(string input, Encoding encoding): string`
- `ToSHA384(string input, Encoding encoding): string`
- `ToSHA512(string input, Encoding encoding): string`
- `ToSHA1(byte[] input, Encoding encoding): string`
- `ToSHA256(byte[] input, Encoding encoding): string`
- `ToSHA384(byte[] input, Encoding encoding): string`
- `ToSHA512(byte[] input, Encoding encoding): string`
- `ToMD5(byte[] input, Encoding encoding): string`
- `ToMD5(string input): string`
- `ToSHA1(string input): string`
- `ToSHA256(string input): string`
- `ToSHA384(string input): string`
- `ToSHA512(string input): string`
- `ToSHA1(byte[] input): string`
- `ToSHA256(byte[] input): string`
- `ToSHA384(byte[] input): string`
- `ToSHA512(byte[] input): string`

### `HTMLConverter`

Provides methods for converting HTML content.

- `ToHTMLEscape(string input): string`
- `FromHTMLEscape(string input): string`

### `JsonConverter`

Static class offering JSON serialization and deserialization methods.

- `JsonToObject<T>(string json): T`
- `ObjectToJson<T>(T obj): string`



## Contributing

Feel free to contribute to the development of this NuGet package. Submit issues or pull requests on the [GitHub repository](https://github.com/your/repo).

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
