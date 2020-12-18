@ModelType IEnumerable(Of WebApplication2.Book)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Author)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Category)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TotalPages)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CreatedOn)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UpdatedOn)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CoverImageUrl)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.BookPdfUrl)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Language.Name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Author)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Category)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TotalPages)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CreatedOn)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UpdatedOn)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CoverImageUrl)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.BookPdfUrl)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Language.Name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
