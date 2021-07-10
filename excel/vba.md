#### Create automatic chart with macros button in same worksheet
    <html>
    Private Sub CommandButton1_Click()

    Range("A1:A5,B1:B5").Select
    ActiveSheet.Shapes.AddChart.Select
    ActiveChart.SetSourceData Source:=Range("'vba chart button'!$A$1:$A$5,'vba chart button'!$B$1:$B$5")
    ActiveChart.ChartType = xlColumnClustered
    ActiveSheet.ChartObjects(1).Activate
    Sheets("vba chart button").Select
    
    End Sub
    </html>
