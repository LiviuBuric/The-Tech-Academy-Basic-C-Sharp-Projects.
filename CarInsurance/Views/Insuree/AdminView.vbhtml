@ModelType List(Of CarInsurance.Insuree)

@Using Html.BeginForm
    @<fieldset>
        <table>
            <tr>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Email</th>
                <th>Quote</th>
            </tr>
            @If Model IsNot Nothing Then
                @For Each item As CarInsurance.Insuree In Model
                    @<tr>
                        <td>@item.FirstName</td>
                        <td>@item.LastName</td>
                        <td>@item.EmailAddress</td>
                        <td>@item.Quote</td>
                    </tr>
                Next
            Else
                @<tr>
                    <td colspan="4">No data available.</td>
                </tr>
            End If
        </table>
        <p><input type="submit" name="submit" /></p>
    </fieldset>
End Using
