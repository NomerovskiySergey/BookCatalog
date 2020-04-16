var Author = Author || {};

(function () {
    var me = this;

    me.editAuthorUrl = '';
    me.goToMainPage = '';

    var AuthorModelView = ko.validatedObservable({
        Id: ko.observable(),
        FirstName: ko.observable().extend({ required: true }),
        LastName: ko.observable().extend({ required: true }),
        BookCount: ko.observable()
    });

    me.onSaveClick = function () {
        if (AuthorModelView.isValid()) {
            $.post(me.saveAuthorUrl, ko.mapping.toJS(AuthorModelView),
                function () {
                    toastr.success('Author successfully added');
                    location.href = me.goToMainPage;
                }, function () {

                });
        } else {
            AuthorModelView.errors.showAllMessages();
        }
    };

    me.onEditClick = function () {
        if (AuthorModelView.isValid()) {
            $.post(me.editAuthorUrl, ko.mapping.toJS(AuthorModelView))
            .done(function() {
                location.href = me.goToMainPage;
            });
        } else {
            AuthorModelView.errors.showAllMessages();
        }
    };

    function knockoutConfiguration(authorModel) {

        if (authorModel != undefined) {
            var validationMapping = {
                FirstName: {
                    create: function (options) {
                        return ko.observable(options.data).extend({ required: true });
                    }
                },
                LastName: {
                    create: function (options) {
                        return ko.observable(options.data).extend({ required: true });
                    }
                }
            };

            AuthorModelView = ko.validatedObservable(ko.mapping.fromJS(authorModel, validationMapping));
        }

        ko.validation.init({
            decorateInputElement: true,
            errorMessageClass: 'errorMessageStyle'
        }, true);

        ko.applyBindings(AuthorModelView);
    };

    me.Init = function (authorModel) {
        knockoutConfiguration(authorModel);
    };
}).apply(Author);
