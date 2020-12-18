@ModelType WebApplication2.Book
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Book</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Author)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Author)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Category)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Category)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TotalPages)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TotalPages)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CreatedOn)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CreatedOn)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UpdatedOn)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UpdatedOn)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CoverImageUrl)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CoverImageUrl)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.BookPdfUrl)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.BookPdfUrl)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Language.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Language.Name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
