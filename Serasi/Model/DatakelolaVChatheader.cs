using System;
using System.Collections.Generic;

#nullable disable

namespace WebApiBravo.Models
{
    public partial class DatakelolaVChatheader
    {
        public string AccountId { get; set; }
        public decimal? Id { get; set; }
        public decimal ChannelUserId { get; set; }
        public string Subject { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? ChannelPageId { get; set; }
        public decimal? ChannelId { get; set; }
        public decimal? ChannelAccountId { get; set; }
        public decimal? HandleBy { get; set; }
        public DateTime? StartChatWaitingResponAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? EndedAt { get; set; }
        public string ChatWidgetUniqueId { get; set; }
        public string Type { get; set; }
        public string AdditionalData { get; set; }
        public long? Duration { get; set; }
        public DateTime? ChannelUserLatestMessageAt { get; set; }
        public decimal? CompanyId { get; set; }
        public string TicketNumber { get; set; }
        public decimal? ChatTicketStatusId { get; set; }
        public string ChannelName { get; set; }
        public decimal? ChannelPagesId { get; set; }
        public string ChannelPagesName { get; set; }
    }
}
