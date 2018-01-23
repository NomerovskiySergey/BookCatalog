var Author = Author || {};

(function () {
    var me = this;

    me.saveAuthorUrl = '';
    me.goToMainPage = '';

    var AuthorModelView = ko.validatedObservable({
        FirstName: ko.observable().extend({ required: true }),
        LastName: ko.observable().extend({ required: true })
    });

    me.onSaveClick = function () {
        if (AuthorModelView.isValid()) {
            $.post(me.saveAuthorUrl, ko.mapping.toJS(AuthorModelView),
                function () {
                    location.href = me.goToMainPage;
                }, function () {

                });
        } else {
            AuthorModelView.errors.showAllMessages();
        }
    };

    function knockoutConfiguration() {
        ko.validation.init({
            decorateInputElement: true,
            errorMessageClass: 'errorMessageStyle'
        }, true);

        ko.applyBindings(AuthorModelView);
    };

    me.Init = function () {
        knockoutConfiguration();
    };
}).apply(Author);
