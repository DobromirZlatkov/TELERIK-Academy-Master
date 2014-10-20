/// <reference path="../libs/jquery.js" />
define(['jquery'], function ($) {

    var DataController = (function () {


        var $li = document.createElement('li'),
          $span = document.createElement('span'),
          $strong = document.createElement('strong'),
          $spanForTitle = $span.cloneNode(true),
          $spanForDate = $span.cloneNode(true);

        $li.className = 'msgln';
        $li.appendChild($strong);
        $li.appendChild($spanForTitle);
        $li.appendChild($span);
        $li.appendChild($spanForDate);

        function messageRender(postBy, title, body, postDate) {

            $strong.innerHTML = postBy + ': ';
            $span.innerHTML = body;
            $spanForTitle.innerHtml = title;
            $spanForDate.innerHtml = postDate;

            return $li.cloneNode(true);

        }

        function chatBoxRenderer(data, numberOfMessagesToRemove) {
            var fragment = document.createDocumentFragment(),
                i,
                messagesLeft = data.length - numberOfMessagesToRemove,
                len = data.length - 1,
                $messageList = $('<ul />');

            for (i = len; i >= messagesLeft; i -= 1) {
                var postBy = data[i].user[username];
                var title = data[i].title;
                var body = data[i].body;
                var postDate = data[i].postDate;

                fragment.appendChild(messageRender(postBy, title, body, postDate));

            }
           
            return fragment;
        }


        return {
            chatBoxRenderer: chatBoxRenderer,
            messageRender: messageRender
        }

    }());

    return DataController;
});