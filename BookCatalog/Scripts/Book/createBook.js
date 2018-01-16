var Book = Book || {};

(function() {
    var me = this;

    me.saveBookUrl = '';

    me.BookModelView = function () {
        this.SelectedAuthors = ko.observableArray([]);
        this.Title = ko.observable('Test');
        this.ReleaseDate = ko.observable();
        this.Rating = ko.observable(123);
        this.PageCount = ko.observable(123123);
    };

    me.onSaveClick = function() {
        debugger;
        var data = ko.mapping.toJS(me.BookModelView);

        $.post(me.saveBookUrl, data, function() {
            console.log('onSaveClick');
        });
    };


    me.Init = function(releaseDateControlId, authorControlId) {

        $(releaseDateControlId).datetimepicker();
        $(authorControlId).selectpicker();

        ko.applyBindings(new me.BookModelView());
    };
}).apply(Book);