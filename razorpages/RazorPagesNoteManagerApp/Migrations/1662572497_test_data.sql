insert
into note (
    article_id,
    note,
    author,
    hided,
    voted_up,
    voted_down
)
values
(
    1,
    'first simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi ante felis, convallis quis nunc ultricies, mattis elementum felis. Aenean arcu lacus, suscipit vitae fermentum a.',
    'michalkubrak.90@gmail.com',
    FALSE,
    14,
    120
),
(
    2,
    'second another simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut vulputate massa in tortor laoreet euismod. Curabitur venenatis iaculis elit, eget euismod arcu commodo vel. Suspendisse.',
    'michalkubrak.90@gmail.com',
    FALSE,
    154,
    17
),
(
    3,
    'third another simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur justo tortor, porta eleifend turpis sed, efficitur consectetur purus. Pellentesque habitant morbi tristique senectus et netus.',
    'michalkubrak.90@gmail.com',
    FALSE,
    2,
    3
),
(
    4,
    'fourth another simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur justo tortor, porta eleifend turpis sed, efficitur consectetur purus. Pellentesque habitant morbi tristique senectus et netus.',
    'michalkubrak.90@gmail.com',
    FALSE,
    2,
    3
),
(
    5,
    'fifth another simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur justo tortor, porta eleifend turpis sed, efficitur consectetur purus. Pellentesque habitant morbi tristique senectus et netus.',
    'michalkubrak.90@gmail.com',
    FALSE,
    2,
    3
),
(
    6,
    'sixth another simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur justo tortor, porta eleifend turpis sed, efficitur consectetur purus. Pellentesque habitant morbi tristique senectus et netus.',
    'michalkubrak.90@gmail.com',
    FALSE,
    2,
    3
);

insert
into note (
    article_id,
    note,
    author,
    hided,
    voted_up,
    voted_down,
    answer_on
)
values
(
    1,
    'first answer on first simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec tellus turpis, lobortis et elementum sed, pulvinar sit amet neque. Suspendisse quis dolor et magna lacinia.',
    'testmail1234@gmail.com',
    FALSE,
    10,
    15,
    1
),
(
    1,
    'second answer on first simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et vehicula justo, ut tristique massa. Sed vel semper nunc. Aliquam dapibus vestibulum justo, eu egestas.',
    'testmail1234567@gmail.com',
    FALSE,
    1,
    4,
    1
),
(
    2,
    'first answer on second simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer molestie nisi eros, et feugiat purus consectetur sed. Nullam mattis metus risus. Cras pulvinar vitae velit.',
    'testmail1234567@gmail.com',
    FALSE,
    15,
    101,
    2
),
(
    4,
    'first answer on fourth simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer molestie nisi eros, et feugiat purus consectetur sed. Nullam mattis metus risus. Cras pulvinar vitae velit.',
    'testmail1234567@gmail.com',
    FALSE,
    15,
    101,
    4
),
(
    6,
    'first answer on sixth simple note. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer molestie nisi eros, et feugiat purus consectetur sed. Nullam mattis metus risus. Cras pulvinar vitae velit.',
    'testmail1234567@gmail.com',
    FALSE,
    15,
    101,
    6
);