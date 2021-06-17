IronBarCode  - The BarCode and QR Library for .Net 
=============================================================
Quickstart:  https://ironsoftware.com/csharp/barcode/
	

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
