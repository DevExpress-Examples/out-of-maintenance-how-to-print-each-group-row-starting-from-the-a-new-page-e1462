<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630756/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1462)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q205815/Form1.cs) (VB: [Form1.vb](./VB/Q205815/Form1.vb))
* [MyGridControl.cs](./CS/Q205815/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/Q205815/MyGridControl.vb))
<!-- default file list end -->
# How to print each Group Row starting from the a new page


<p>XtraGrid provides the capability to control the process of printing Grid View via the OptionsPrint property. However, these options don't allow you to perform any complex customization. The best way to completely override the default behavior is to use the <a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXtraReporttopic">XtraReport</a> class for printing purposes. The <a href="https://www.devexpress.com/Support/Center/p/AK17175">How to convert an XtraGrid to an XtraReport at runtime</a> knowledge base article demonstrates how to convert the GridView to the XtraReport in code.<br />
Also, some changes can be made by creating an XtraGrid descendant and overriding the basic implementation of the printing mechanism. This example demonstrates how to force the GridView to print each Group Row with all child rows on a new page.</p>

<br/>


