# How to print each Group Row starting from the a new page


<p>XtraGrid provides the capability to control the process of printing Grid View via the OptionsPrint property. However, these options don't allow you to perform any complex customization. The best way to completely override the default behavior is to use the <a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXtraReporttopic">XtraReport</a> class for printing purposes. The <a href="https://www.devexpress.com/Support/Center/p/AK17175">How to convert an XtraGrid to an XtraReport at runtime</a> knowledge base article demonstrates how to convert the GridView to the XtraReport in code.<br />
Also, some changes can be made by creating an XtraGrid descendant and overriding the basic implementation of the printing mechanism. This example demonstrates how to force the GridView to print each Group Row with all child rows on a new page.</p>

<br/>


