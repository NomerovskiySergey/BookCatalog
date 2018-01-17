var Book = Book || {};

(function() {
    var me = this;

    me.saveBookUrl = '';

    var BookModelView =ko.validatedObservable( {
        SelectedAuthors : ko.observableArray([]),
        Title : ko.observable().extend({ required: true }),
        ReleaseDate : ko.observable(),
        Rating : ko.observable(123),
        PageCount : ko.observable(123123)
    });

    me.onSaveClick = function() {
        var data = ko.mapping.toJS(BookModelView);
        

        if (BookModelView.isValid()) {
            $.post(me.saveBookUrl,
                            data,
                            function() {
                                console.log('onSaveClick');
                            });
        } else {
            BookModelView.errors.showAllMessages();
        }


    };


    me.Init = function (releaseDateControlId, authorControlId) {

        $(authorControlId).selectpicker();

        ko.validation.init({
            insertMessages: false,
            decorateInputElement: true,
            errorElementClass: 'errorStyle'
        }, true);

        ko.applyBindings(BookModelView);
    };
}).apply(Book);