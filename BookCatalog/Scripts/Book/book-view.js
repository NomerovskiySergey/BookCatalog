var Book = Book || {};

(function() {
    var me = this;

    me.releaseDateControlId = "";
    me.authorControlId = "";

    me.BookModel = function () {
        this.selectedAuthors = ko.observableArray([]);
        this.test = ko.observable("test");
    };


    me.Init = function(releaseDateControlId, authorControlId) {

        me.releaseDateControlId = releaseDateControlId;
        me.authorControlId = authorControlId;

        $(releaseDateControlId).datetimepicker();
        $(authorControlId).selectpicker();

        ko.applyBindings(new me.BookModel());
    };
}).apply(Book);