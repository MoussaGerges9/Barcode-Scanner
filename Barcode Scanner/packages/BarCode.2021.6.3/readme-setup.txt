IronBarCode  - The BarCode and QR Library for .Net 
=============================================================
Quickstart:  https://ironsoftware.com/csharp/barcode/
	

Installation for .Net Framework 4.0 + 
=============================================================
- Include IronBarCode.dll in  net45 folder into your project
- Add Assembly references to:
	* System.Configuration
	* System.Drawing
	* System.Web
 

Installation for .Net Standard & .Net Core 2.0+  & .Net 5
=============================================================
- Include IronBarCode.dll in netstandard2.0 folder into your project
- Add a Nuget Package Reference to:
		* System.Drawing.Common 4.7 or higher


Compatibility
=============================================================
Supports applications and websites developed in 
- .Net FrameWork 4.0 (and above) for Windows and Azure
- .Net Core 2, 3 (and above) for Windows, Linux, MacOs and Azure
- .Net 5

C# Code Example
=============================================================
```
using IronBarCode;
    
// Create A Barcode in 1 Line of Code
BarcodeWriter.CreateBarcode("https://ironsoftware.com/csharp/barcode", BarcodeWriterEncoding.QRCode).SaveAsJpeg("QuickStart.jpg");

// Read A Barcode in 1 Line of Code.  
BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode("QuickStart.jpg");
```

Documentation
=============================================================

- Code Samples				:	https://ironsoftware.com/csharp/barcode/examples/barcode-quickstart/
- MSDN Class Reference		:	https://ironsoftware.com/csharp/barcode/object-reference/
- Tutorials					:	https://ironsoftware.com/csharp/barcode/tutorials/reading-barcodes/
- Support					:	developers@ironsoftware.com
