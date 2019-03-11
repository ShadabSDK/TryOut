using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutAutofac
{
    public interface IMemoDueNotifier
    {
        void MemoIsDue(Memo memo);
    }

    public class PrintingNotifier : IMemoDueNotifier
    {
        TextWriter _writer;

        public PrintingNotifier(TextWriter writer)
        {
            _writer = writer;
        }
        public void MemoIsDue(Memo memo)
        {
            Console.WriteLine("Memo '{0}' is due!", memo.Title);
        }
    }
    public class Memo
    {
        public DateTime DueAt { get; set; }

        public string Title { get; set; }
    }

    public class MemoChecker
    {
        private IQueryable<Memo> _memos;
        private IMemoDueNotifier _notifier;
        public MemoChecker(IQueryable<Memo> memos,IMemoDueNotifier notifier)
        {
            _memos = memos;
            _notifier = notifier;        
        }

        // Check for overdue memos and alert the notifier of any that are found. 

        public void CheckAndNotify()
        {
            var overdueMemos = _memos.Where(memo => memo.DueAt < DateTime.Now);

            foreach (var memo in overdueMemos)
                _notifier.MemoIsDue(memo);

        }
    }
}
