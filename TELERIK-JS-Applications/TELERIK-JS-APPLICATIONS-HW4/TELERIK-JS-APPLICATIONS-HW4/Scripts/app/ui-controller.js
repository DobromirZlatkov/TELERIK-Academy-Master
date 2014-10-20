/// <reference path="../libs/jquery.js" />
define(['jquery'], function ($) {

    var UI = (function () {

        var $div = document.createElement('div'),
            $span = document.createElement('span'),
            $strong = document.createElement('strong');

        $div.className = 'msgln';
        $div.appendChild($strong);
        $div.appendChild($span);

        function createMessage(postedBy, text) {
            if (text.length > 100) {
                text = text.substr(0, 100) + '...';
            }

            $strong.innerHTML = postedBy + ': ';
            $span.innerHTML = text;

            return $div.cloneNode(true);
        }

        function createChatBox(data, messageCount) {
            var fragment = document.createDocumentFragment();
            
            for (var i = data.length - 1; i > Math.max(data.length - messageCount, 0) ; i--) {
                var post = data[i];
                postBy = post.by.trim() || 'Anonymous';
                postText = post.text.trim();
                
                if (!postText) {
                    continue;
                }

                var postHtml = createMessage(postBy, postText);
                
                fragment.appendChild(postHtml);
            }

            return fragment;
        }

        return {
            createMessage: createMessage,
            createChatBox: createChatBox
        }

    }());

    return UI;
});