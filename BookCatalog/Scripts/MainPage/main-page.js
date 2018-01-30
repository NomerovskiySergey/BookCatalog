var Catalog = Catalog || {};

(function () {
    var me = this;

    me.loadDataUrl = '';
    me.deleteBook = '';

    function RenderAuthorRow(data) {
        var autrhorsLookupValueArr = data.split(';')
        var outputHtml = '';

        for (var i = 0; i < autrhorsLookupValueArr.length; i++) {

            var authorArr = autrhorsLookupValueArr[i].split('#');

            if (authorArr[0].length != 0) {
                outputHtml += '<a href="/Author/Edit/' + authorArr[0] + '">' + authorArr[1] + '</a>; '
            }
        }

        return outputHtml;
    };

    function RenderButtonsRow(data) {
        var outputHtml = '';

        //outputHtml += "<a href='' " + data + "' class='btn btn-info' role='button' >Edit</a> ";
        outputHtml += "<div id='delete_btn' class='btn btn-info' role='button' data-id='" + data + "'' onclick='Catalog.onDelete(this)'>Delete</div>";

        return outputHtml;
    };

    me.onDelete = function(e) {
        $.post(me.deleteBook, { bookId: $(e).data('id') },
            function() {
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
                type: 'POST',
            },
            columns: [
                { "data": "Id", "title": " "},
                { "data": "Title" },
                { "data": "ReleaseDate" },
                { "data": "Rating" },
                { "data": "PageCount" },
                { "data": "Author" },
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