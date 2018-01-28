var Catalog = Catalog || {};

(function () {
    var me = this;

    me.loadDataUrl = '';

    function RenderAuthorRow(data) {
        var autrhorsLookupValueArr = data.split(';')
        var outputHtml = '';

        for (var i = 0; i < autrhorsLookupValueArr.length; i++) {
            
            var authorArr = autrhorsLookupValueArr[i].split('#');

            if(authorArr[0].length != 0){
                outputHtml += '<a href="/Author/Edit/' + authorArr[0] + '">' + authorArr[1] + '</a>; '
            }
        }

        return outputHtml
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
                { "data": "Id" },
                { "data": "Title" },
                { "data": "ReleaseDate" },
                { "data": "Rating" },
                { "data": "PageCount" },
                { "data": "Author" },
            ],
            columnDefs: [{
                targets: 5,
                data: "Author",
                render: function (data, type, row, meta) {
                    return RenderAuthorRow(data);
                }
            }]
        });
    };
}).apply(Catalog);