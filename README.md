# How to display data labels inside segments in .NET MAUI SfCartesian Chart

This sample demonstrates how to display data labels inside segments in a .NET MAUI SfCartesian Chart for better visualization. It utilizes the column series properties, including [LabelTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html?tabs=tabid-9%2Ctabid-11%2Ctabid-5%2Ctabid-7%2Ctabid-18%2Ctabid-1%2Ctabid-22%2Ctabid-24%2Ctabid-16%2Ctabid-20%2Ctabid-14%2Ctabid-13%2Ctabid-3#Syncfusion_Maui_Charts_ChartSeries_LabelTemplate), [LabelPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html?tabs=tabid-5%2Ctabid-3%2Ctabid-1#Syncfusion_Maui_Charts_ChartDataLabelSettings_LabelPlacement), and [BarAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianDataLabelSettings.html?tabs=tabid-1%2Ctabid-3%2Ctabid-5#Syncfusion_Maui_Charts_CartesianDataLabelSettings_BarAlignment).

![Screenshot 2024-07-10 125122](https://github.com/SyncfusionExamples/How-to-display-data-labels-inside-segments-in-.NET-MAUI-SfCartesian-Chart/assets/124584591/d7bd2fba-715c-4c01-8e91-eb63b2698906)

In this sample, we customize the chart using following features.

* [LabelTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LabelTemplate): This feature allows users to customize the appearance of data labels. By defining a label template, users can control the layout, style, and content of the labels, making the data representation more informative and visually appealing.

* [BarAlignment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianDataLabelSettings.html#Syncfusion_Maui_Charts_CartesianDataLabelSettings_BarAlignment): This feature allows users to specify the position of the data label in column-type series. It helps in aligning the labels precisely where needed for better clarity. The available values are:

    * [Middle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelAlignment.html#Syncfusion_Maui_Charts_DataLabelAlignment_Middle): Aligns the label in the middle of the column.
    * [Top](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelAlignment.html#Syncfusion_Maui_Charts_DataLabelAlignment_Top): Aligns the label at the top of the column.
    * [Bottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelAlignment.html#Syncfusion_Maui_Charts_DataLabelAlignment_Bottom): Aligns the label at the bottom of the column.
 
* [LabelPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartDataLabelSettings.html#Syncfusion_Maui_Charts_ChartDataLabelSettings_LabelPlacement): This feature provides support for placing data labels in specific positions relative to the chart segments. It is an enumeration type with the following values:

    * [Center](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Center): Places the label at the center of the Label Bar Alignmnet.
    * [Inner](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Inner): Places the label inside of the Label Bar Alignmnet.
    * [Outer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelPlacement.html#Syncfusion_Maui_Charts_DataLabelPlacement_Outer): Places the label outside of the Label Bar Alignmnet.

For more information about the sample refer the [KB article]().
