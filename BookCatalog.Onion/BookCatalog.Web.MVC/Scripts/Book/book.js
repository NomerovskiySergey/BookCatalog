var Book = Book || {};

(function () {
    var me = this;

    me.saveBookUrl = '';
    me.goToMainPage = '';
    me.getBookUrl = '';

    var BookModelView = ko.validatedObservable({
        Title: ko.observable().extend({ required: true }),
        ReleaseDate: ko.observable().extend({ required: true }),
        AuthorsIds: ko.observableArray([]).extend({ required: true }),
        RatingArr: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10],
        Rating: ko.observable().extend({ required: true }),
        PageCount: ko.observable().extend({ number: true, required: true })
    });

    me.onSaveClick = function () {
        if (BookModelView.isValid()) {
            $.post(me.saveBookUrl, ko.mapping.toJS(BookModelView))
                .done(function () {
                    toastr.success('Book successfully added');
                    location.href = me.goToMainPage;
                })
                .fail(function (e) {
                    toastr.success('Book successfully created');
                });
        } else {
            BookModelView.errors.showAllMessages();
        }
    };

    me.onCancelClick = function() {
        location.reload();
    };

    me.onEditClick = function(e) {
        $.get(me.getBookUrl + "?bookId=" + $(e).data('id'),
            function (data) {
                BookModelView().Id = data.Id;
                BookModelView().Title(data.Title);
                BookModelView().PageCount(data.PageCount);
                BookModelView().ReleaseDate(data.ReleaseDate);
                BookModelView().Rating(data.Rating);
                BookModelView().AuthorsIds(data.AuthorsIds);

                $('#author').selectpicker('val', data.AuthorsIds);
                $('.selectpicker').selectpicker('refresh');
                $(".collapse").collapse('show');
            });
    };

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
        $(releaseDateControlId).datepicker({
            format: 'dd.mm.yyyy'
        });

        knockoutConfiguration();
    };
}).apply(Book);

