var Catalog = Catalog || {};

(function () {
    var me = this;

    me.loadDataUrl = '';
    me.deleteBookUrl = '';

    function RenderAuthorRow(data) {
        var autrhorsLookupValueArr = data.split(';')
        var outputHtml = '';

        for (var i = 0; i < autrhorsLookupValueArr.length; i++) {

            var authorArr = autrhorsLookupValueArr[i].split('#');

            if (authorArr[0].length != 0) {
                outputHtml += '<a href="author/Author/Edit/' + authorArr[1] + '/' + authorArr[0] + '">' + authorArr[1] + '</a>; ';
            }
        }

        return outputHtml;
    };

    function RenderButtonsRow(data) {
        var outputHtml = '';

        outputHtml += "<div id='edit_btn' data-id='" + data + "' class='btn btn-info edit_btn' role='button' onclick='Book.onEditClick(this)'>Edit</div> ";
        outputHtml += "<div id='delete_btn' class='btn btn-info' role='button' data-id='" + data + "'' onclick='Catalog.onDelete(this)'>Delete</div>";

        return outputHtml;
    };

    me.onDelete = function (e) {
        $.post(me.deleteBookUrl, { bookId: $(e).data('id') },
            function () {
                location.reload();
            });
    }

    me.Init = function (tableId) {
        $(tableId).DataTable({
            paging: true,
            serverSide: true,
            ordering: false,
            ajax: {
                url: me.loadDataUrl,
                type: 'POST'
            },
            columns: [
                { "data": "Id", "title": " ", "searchable": "false" },
                { "data": "Title" },
                { "data": "ReleaseDate", "searchable": "false" },
                { "data": "Rating", "searchable": "false" },
                { "data": "PageCount", "searchable": "false" },
                { "data": "Author", "searchable": "false" }
            ],
            columnDefs: [
                {
                    targets: 0,
                    data: "Id",
                    render: function (data, type, row, meta) {
                        return RenderButtonsRow(data);
                    }
                },
                {
                    targets: 5,
                    data: "Author",
                    render: function (data, type, row, meta) {
                        return RenderAuthorRow(data);
                    }
                }
            ]
        });
    };
}).apply(Catalog);