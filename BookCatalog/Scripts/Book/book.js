var Book = Book || {};

(function () {
    var me = this;

    me.saveBookUrl = '';
    me.goToMainPage = '';

    var BookModelView = ko.validatedObservable({
        Title: ko.observable().extend({ required: true }),
        ReleaseDate: ko.observable().extend({ required: true }),
        SelectedAuthorsIds: ko.observableArray([]).extend({ required: true }),
        RatingArr: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
        Rating: ko.observable().extend({ required: true }),
        PageCount: ko.observable().extend({ number: true, required: true })
    });

    me.onSaveClick = function () {
        if (BookModelView.isValid()) {
            $.post(me.saveBookUrl, ko.mapping.toJS(BookModelView),
               function () {
                   location.href = me.goToMainPage;
               }, function () {
                    
               });
        } else {
            BookModelView.errors.showAllMessages();
        }
    };

    me.onEditClick = function () { };

    function knockoutConfiguration() {
        ko.validation.init({
            decorateInputElement: true,
            errorMessageClass: 'errorMessageStyle'
        }, true);
        ko.mapping.defaultOptions().ignore = ["RatingArr"];
        ko.applyBindings(BookModelView);
    };

    me.Init = function (releaseDateControlId, authorControlId) {

        $(authorControlId).selectpicker();
        $(releaseDateControlId).datepicker();

        knockoutConfiguration();
    };
}).apply(Book);

