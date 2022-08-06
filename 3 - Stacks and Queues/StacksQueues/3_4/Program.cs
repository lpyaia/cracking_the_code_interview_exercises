using _3_4;

var queue = new MyQueue<int>();

queue.Queue(1);
queue.Queue(2);
queue.Queue(3);
queue.Queue(4);

queue.Unqueue();

queue.Queue(5);

queue.Unqueue();
queue.Unqueue();
queue.Unqueue();
queue.Unqueue();